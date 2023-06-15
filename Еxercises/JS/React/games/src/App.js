
import { Route, Routes } from 'react-router-dom';
import Header from "./components/Header";
import Home from "./components/Home";
import Login from "./components/Login";
import Register from "./components/Register";
import CreateGame from "./components/CreateGame";
//import EditGame from "./components/EditGame";
import DetailsGame from "./components/DetailsGame";
import CatalogGame from "./components/GameCatalog/CatalogGame";

function App() {
  return (
    <div id="box">

      <Header />

      <main id="main-content">
        <Routes>
          <Route path='/' exact element={<Home />} />
          <Route path='/login' element={<Login />} />
          <Route path='/register' element={<Register />} />
          <Route path='/create-game' element={<CreateGame />} />
          <Route path='/games' exact element={<CatalogGame />} />
          <Route path='/details/:gameId' element={<DetailsGame />} />
        </Routes>

      </main>

    </div>
  );
}

export default App;
