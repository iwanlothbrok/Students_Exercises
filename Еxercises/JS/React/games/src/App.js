
import { useState } from 'react';

import Header from "./components/Header";
import Home from "./components/Home";
import Login from "./components/Login";
import Register from "./components/Register";
import CreateGame from "./components/CreateGame";
//import EditGame from "./components/EditGame";
import DetailsGame from "./components/DetailsGame";
import CatalogGame from "./components/GameCatalog/CatalogGame";

function App() {
  const [page, setPage] = useState('/home');

  const navigationChangeHandler = (path) => {
    setPage(path)
  }

  const router = (path) => {
    let pathNames = path.split('/');
    console.log(path);
    console.log(pathNames);
    let rootPath = pathNames[1];
    let argument = pathNames[2];

    console.log(rootPath);

    const routes = {
      'home': <Home />,
      'register': <Register />,
      'login': <Login />,
      'create-game': <CreateGame />,
      'catalog-page': <CatalogGame navigationChangeHandler={navigationChangeHandler} />,
      'details': <DetailsGame id={argument} />,
    };

    return routes[rootPath];
  }

  return (
    <div id="box">

      <Header navigationChangeHandler={navigationChangeHandler} />

      <main id="main-content">
        {router(page) || <h2>No Page Founded!</h2>}
      </main>

    </div>
  );
}

export default App;
