import React, { useState } from 'react'

export default function Flashcard({ flashcards }) {
    const [flip, setFlip] = useState(false);



    return (
        <div
            onClick={() => setFlip(!flip)}
            className={`card' ${flip ? 'flip' : ''}`}>

            <div className='front'>
                {flashcards.question}
                <div className='flashcard-options'>
                    {flashcards.options.map(op => {
                        return <div className='flashcard-option'>{op}</div>
                    })}
                </div>
            </div>

            <div className='back'>{flashcards.answer}</div>
        </div>
    )
}
