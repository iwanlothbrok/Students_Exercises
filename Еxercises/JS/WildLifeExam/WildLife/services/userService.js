const User = require('../models/User');
const { hash, compare } = require('bcrypt');


async function register(username, password) {
    // checking if there is any user with this username FOR NOW 
    const existing = await getUserByUsername(username);

    if (existing) {
        throw new Error('Username is taken');
    }

    // hashing the passoword with the bcrypt func hash which is included
    const hashedPassword = await hash(password,10);

    // if everything is okay we are adding the user in the database 
    const user = new User({
        username,
        hashedPassword
    });

    await user.save();

    return user;
}


// getting the user by username FOR NOW 
async function getUserByUsername(username) {
    const user = await User.find({ username });

    return user;
}