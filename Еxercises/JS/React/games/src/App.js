import Header from "./components/Header";
import Home from "./components/Home";
import Login from "./components/Login";
import Register from "./components/Register";
import CreateGame from "./components/CreateGame";
import EditGame from "./components/EditGame";
import DetailsGame from "./components/DetailsGame";
import CatalogGame from "./components/CatalogGame";

function App() {
  const router = {
    '/home': Home,
    '/register': Register,
    '/games' : CatalogGame,
    '/login' : Login,
    '/create-game' : CreateGame
  };
  return (
    <div id="box">

      <Header />

      <main id="main-content">
        <Home />
      </main>

      {/* 
      <Login />
      <Register />
      <CreateGame />
      <EditGame />
      <DetailsGame />
      <CatalogGame /> */}
    </div>
  );
}

export default App;
