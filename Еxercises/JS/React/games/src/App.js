
import { useState } from 'react';

import Header from "./components/Header";
import Home from "./components/Home";
import Login from "./components/Login";
import Register from "./components/Register";
import CreateGame from "./components/CreateGame";
import EditGame from "./components/EditGame";
import DetailsGame from "./components/DetailsGame";
import CatalogGame from "./components/CatalogGame";

function App() {
  const [page, setPage] = useState('/home');
  
  const navigationChangeHandler = (path) => {
    setPage(path)
  }
  
  const router = {
    '/home': <Home />,
    '/register': <Register />,
    '/login': <Login />,
    '/create-game': <CreateGame />,
    '/catalog-page': <CatalogGame navigationChangeHandler={navigationChangeHandler} />,
    '/details': <DetailsGame />,
  };

  return (
    <div id="box">

      <Header navigationChangeHandler={navigationChangeHandler} />

      <main id="main-content">
        {router[page] || <h2>No Page Founded!</h2>}
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
