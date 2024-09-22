import React from 'react'
import '../assets/chrismasform.css'
export default function ChrismasForm() {
    return (
        <main>
            <section id="form-section">
                <div id="form">
                    <h1>Add Present</h1>
                    <form action="#">
                        <label className="goadoa" for="gift">Present:</label>
                        <input type="text" id="gift" name="gift" />

                        <label for="for">For:</label>
                        <input type="text" id="for" name="for" />

                        <label for="price">Price:</label>
                        <input type="number" id="price" name="price" />
                    </form>
                    <div id="btn-container">
                        <button id="add-present">Add Present</button>
                        <button id="edit-present" disabled>Edit Present</button>
                    </div>
                </div>
            </section>

            <div id="wrapper">
                <section id="presents">
                    <button id="load-presents">Load Presents</button>
                    <div id="gift-list">
                    </div>
                </section>
            </div>
        </main>
    )
}
