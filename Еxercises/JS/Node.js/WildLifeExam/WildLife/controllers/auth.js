
const { register, login } = require('../services/userService');
const router = require('express').Router();
const { isUser, isGuest } = require('../middleware/guards');

router.get('/register', isGuest(), (req, res) => {
    res.render('register', { title: 'Register Page' });
});

router.post('/register', isGuest(), async (req, res) => {
    try {
        console.log(res.body);
        if (req.body.password != req.body.repass) {
            throw new Error('Password do not match!')
        }

        const user = await register(req.body.firstName, req.body.lastName, req.body.email, req.body.password);
        req.session.user = user;

        res.render('home', { title: 'Home Page' });
    }
    catch (err) {
        const data = {
            fisrtName: req.body.firstName,
            lastName: req.body.lastName,
            email: req.body.email,
            password: req.body.password
        };

        console.log(err);   
        res.render('register', { title: 'Register Page', data });
    }
});

router.get('/login', isGuest(), (req, res) => {
    res.render('login', { title: 'Login Page' });
})

router.post('/login', isGuest(), async (req, res) => {
    try {
        const user = await login(req.body.email, req.body.password);
        req.session.user = user;
        res.render('home', { title: 'Home Page' });
    }
    catch (err) {
        const data = {
            email: req.body.email,
            password: req.body.password
        };

        res.render('login', { title: 'Login Page', data });
    }
});

router.get('/logout', isUser(), (req, res) => {
    delete req.session.user;
    res.redirect('/');
})

module.exports = router;