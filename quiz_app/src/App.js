
import React, { useState } from 'react'
import FlashcardList from './FlashcardList';
import './app.css';
function App() {
  const [flashcards, setFlashcard] = useState(SAMPLE_FLASHCARDS);

  return (
    <FlashcardList flashcards={flashcards} />
  );
}

const SAMPLE_FLASHCARDS = [
  {
    id: 1,
    question: 'What is 2 + 2?',
    answer: '4',
    options: [
      '2',
      '3',
      '4',
      '5'
    ]
  },
  {
    id: 2,
    question: 'What is the most speaked language?',
    answer: 'Mandarin',
    options: [
      'Mandarin',
      'English',
      'Spanish',
      'Portugal'
    ]
  },
  {
    id: 3,
    question: 'What is 2 + 2?',
    answer: '4',
    options: [
      '2',
      '3',
      '4',
      '5'
    ]
  }
]

export default App;
