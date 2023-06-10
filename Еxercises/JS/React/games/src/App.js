
import {useState, createElement} from 'react';

import Header from "./components/Header";
import Home from "./components/Home";
import Login from "./components/Login";
import Register from "./components/Register";
import CreateGame from "./components/CreateGame";
import EditGame from "./components/EditGame";
import DetailsGame from "./components/DetailsGame";
import CatalogGame from "./components/CatalogGame";

function App() {
  const [page,setPage]= useState('home'); 

  const router = {
    '/home': Home,
    '/register': Register,
    '/games' : CatalogGame,
    '/login' : Login,
    '/create-game' : CreateGame
  };

  const navigationChangeHandler = (path) => {
    setPage(path)
  }
  return (
    <div id="box">

      <Header navigationChangeHandler={navigationChangeHandler}/>

      <main id="main-content">
        {createElement(router[page]) || <h2>No Page Founded!</h2>}
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
