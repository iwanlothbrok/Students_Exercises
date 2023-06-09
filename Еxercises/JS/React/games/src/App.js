import Header from "./components/Header";
import Home from "./components/Home";
import Login from "./components/Login";
import Register from "./components/Register";
import CreateGame from "./components/CreateGame";
import EditGame from "./components/EditGame";
import DetailsGame from "./components/DetailsGame";
import CatalogGame from "./components/CatalogGame";

function App() {
  return (

    <div id="box">

      <Header />

      <main id="main-content">
      </main>

      <Home />

      <Login />

      <Register />

      <CreateGame />

      <EditGame />

      <DetailsGame />
      
      <CatalogGame />
    </div>
  );
}

export default App;
