function create(words) {

   let contentElement = document.getElementById('content');


   words.forEach(w => {
      let createdDiv = document.createElement('div');
      let createdParagElement = document.createElement('p');

      createdParagElement.textContent = w;
      createdParagElement.style.display = 'none';

      createdDiv.appendChild(createdParagElement);

      createdDiv.addEventListener('click', () => {
         if (createdParagElement.style.display == 'block') {
            createdParagElement.style.display = 'none';
         }
         else {

            createdParagElement.style.display = 'block';
         }
      })

      contentElement.appendChild(createdDiv);
   });
}
