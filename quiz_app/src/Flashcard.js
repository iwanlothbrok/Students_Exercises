import React, { useState } from 'react'

export default function Flashcard({ flashcards }) {
    const [flip, setFlip] = useState(false);



    return (
        <div onClick={() => setFlip(!flip)}>
            {flip ? flashcards.answer : flashcards.question}
        </div>
    )
}
