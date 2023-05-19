
const { register, login } = require('../services/userService')
const router = require('express').Router();

router.get('/register', (req, res) => {
    res.render('register', { layout: false });
});

 router.post('/register', async (req, res) => {
    try {
        if (req.body.password != req.body.repass) {
            throw new Error('Password do not match!')
        }
       const user = await register(req.body.username,req.body.password);

       req.session.user = user;

       res.render('/');
    }
    catch (err) {
        res.render('register', { layout: false });
    }
});

router.get('/login', (req, res) => {
    res.render('login', { layout: false });
})

module.exports = router;