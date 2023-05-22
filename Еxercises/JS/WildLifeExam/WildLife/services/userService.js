const User = require('../models/User');
const { hash, compare } = require('bcrypt');


async function register(firstName,lastName,email,password) {
    // checking if there is any user with this username FOR NOW 
    const existing = await getUserByEmail(email);

    if (existing) { 
        throw new Error('Username is taken');
    }

    // hashing the passoword with the bcrypt func hash which is included
    const hashedPassword = await hash(password, 10);

    // if everything is okay we are adding the user in the database 
    const user = new User({
        firstName,
        lastName,
        email,
        hashedPassword
    });

    await user.save();

    return user;
}

async function login(email, passoword) {
    // checking if there is any user with this username FOR NOW 
    // if gives us undefiend we return error
    const user = await getUserByEmail(email);

    if (!user) {
        throw new Error('User does not exists');
    }

    const hasMatched = await compare(hash(passoword), user.hashedPassword);

    if(!hasMatched){
        throw new Error('Incorrect password');
    }

    return user;
}

// getting the user by username FOR NOW 
// now is case insensetive 
async function getUserByEmail(email) {
    const user = await User.findOne({ email: { $regex: new RegExp(`^${email}$`, 'i') } });
  
    return user;
  }

module.exports= {
    login,
    register,
    getUserByEmail: getUserByEmail
}