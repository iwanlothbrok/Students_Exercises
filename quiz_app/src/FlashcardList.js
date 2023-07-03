import React from 'react'
import Flashcard from './Flashcard'

export default function FlashcardList({ flashcards }) {
    return (
        <div className='card-grid'>
            {flashcards.map(f => { return <Flashcard flashcards={f} key={f.id} /> })}
        </div>
    )
}
