export default function Header(
  { navigationChangeHandler,

  }) {
  const onHeaderClick = (e) => {
    e.preventDefault();

    if (e.target.tagName === 'A') {
      let url = new URL(e.target.href);
      navigationChangeHandler(url.pathname); 
      console.log(url);
    }
  }
  return (
    <header onClick={onHeaderClick}>
      <h1><a className="home" href="home">GamesPlay</a></h1>
      <nav>
        <a href="catalog-page">All games</a>
        <div id="user">
          <a href="create-game">Create Game</a>
          <a href="#">Logout</a>
        </div>
        <div id="guest">
          <a href="login">Login</a>
          <a href="register">Register</a>
        </div>
      </nav>
    </header>
  );
}