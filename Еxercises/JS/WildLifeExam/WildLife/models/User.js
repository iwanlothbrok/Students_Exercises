const { Schema, model } = require('mongoose');


// similar to the db models in asp
const userSchema = new Schema({
    firstName: { type: String, require: true },
    lastName: { type: String, require: true },
    email: { type: String, require: true },
    hashedPassword: { type: String, require: true }
});

// for sorting on param username, 1 for asc -1 for desc
userSchema.index({ email: 1 }, {
    unique: true,
    // to become case insensetive
    collation: {
        locale: 'en',
        strength: 2
    }
})

// creates a Mongoose model named User 
const User = model('User',userSchema);

module.exports = User;