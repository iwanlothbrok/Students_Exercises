
import { useEffect, useState } from 'react';
import GameCard from './GameCard';
import * as gameService from '../../services/gameService'


export default function CatalogGame(
    {
        navigationChangeHandler,
    }) {

    const onDetailsButtonClick = (e) => {
        e.preventDefault();

        if (e.target.tagName === 'A') {
            let url = new URL(e.target.href);
            navigationChangeHandler(url.pathname);
        }
    }


    const [games, setGame] = useState([]);


    useEffect(() => {
        gameService.getAll()
            .then(res => {
                setGame(res);
            })
    }, []);


    return (
        <section id="catalog-page" onClick={onDetailsButtonClick}>
            <h1>All Games</h1>

            {games.length > 0
                ? games.map(x => <GameCard key={x._id} game={x} navigationChangeHandler={navigationChangeHandler}/>)
                : <h3 className="no-articles">No articles yet</h3>
            };


        </section>
    )
}