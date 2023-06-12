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
    return (
        <section id="catalog-page" onClick={onDetailsButtonClick}>
            <h1>All Games</h1>
            <div className="allGames">
                <div className="allGames-info">
                    <img src="./images/avatar-1.jpg" />
                    <h6>Action</h6>
                    <h2>Cover Fire</h2>
                    <a href="/details" className="details-button">Details</a>
                </div>

            </div>
            <div className="allGames">
                <div className="allGames-info">
                    <img src="./images/avatar-1.jpg" />
                    <h6>Action</h6>
                    <h2>Zombie lang</h2>
                    <a href="/details" className="details-button">Details</a>
                </div>

            </div>
            <div className="allGames">
                <div className="allGames-info">
                    <img src="./images/avatar-1.jpg" />
                    <h6>Action</h6>
                    <h2>MineCraft</h2>
                    <a href="/details" className="details-button">Details</a>
                </div>
            </div>

            <h3 className="no-articles">No articles yet</h3>
        </section>
    )
}