
import { Link } from "react-router-dom";
export default function Header() {
 
  return (
    <header>
      <h1><Link to='/'>GamesPlay</Link></h1>
      <nav>
        <Link to='/games'>All Games</Link>
        <div id="user">
          <Link to='/create-game'>Create Game</Link>
          <a href="#">Logout</a>
        </div>
        <div id="guest">
          <Link to='/login'>Login</Link>
          <Link to='/register'>Register</Link>
        </div>
      </nav>
    </header>
  );
}