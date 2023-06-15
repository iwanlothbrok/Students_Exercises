
import { useEffect, useState } from 'react';
import GameCard from './GameCard';
import * as gameService from '../../services/gameService'


export default function CatalogGame({game}) {
    const [games, setGame] = useState([]);


    useEffect(() => {
        gameService.getAll()
            .then(res => {
                setGame(res);
            })
    }, []);


    return (
        <section id="catalog-page" >
            <h1>All Games</h1>

            {games.length > 0
                ? games.map(x => <GameCard key={x._id} game={x} />)
                : <h3 className="no-articles">No articles yet</h3>
            };
        </section>
    )
}