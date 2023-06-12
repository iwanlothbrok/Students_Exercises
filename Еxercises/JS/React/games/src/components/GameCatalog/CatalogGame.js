
import { useEffect, useState } from 'react';
import GameCard from './GameCard';
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
        fetch('http://localhost:3030/data/games?sortBy=_createdOn%20desc')
            .then(res => res.json()
                .then(result => {
                    setGame(result);
                }));
    }, []);


    return (
        <section id="catalog-page" onClick={onDetailsButtonClick}>
            <h1>All Games</h1>

            {games.length > 0
                ? games.map(x => <GameCard key={x._id} game={x} />)
                : <h3 className="no-articles">No articles yet</h3>
            };

 
        </section>
    )
}