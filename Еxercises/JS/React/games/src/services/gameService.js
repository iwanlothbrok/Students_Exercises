const baseUlr = 'http://localhost:3030/data';

export function getAll() {
    return fetch(`${baseUlr}/games?sortBy=_createdOn%20desc`)
        .then(res => res.json());
};

export function getOne(id){
    return fetch(`${baseUlr}/games/${id}`)
        .then(res => res.json());
}