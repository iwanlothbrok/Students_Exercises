import React from 'react'

export default function Test({ test }) {

    const { id, title } = test;

    return (
        <div data-testid={`test-${id}`}>{title}</div>
    )
}
