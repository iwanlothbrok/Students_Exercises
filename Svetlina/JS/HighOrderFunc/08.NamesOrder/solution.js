function solve() {
    const inputField = document.getElementsByTagName('input')[0];
    let list = document.getElementsByTagName('li');
  
    document
        .getElementsByTagName('button')[0]
        .addEventListener('click', () => {
            let name = inputField.value;
            if (name) {
                let resultName = name[0].toLocaleUpperCase();
                let index = resultName.charCodeAt(0) - 65;
                resultName += name.slice(1).toLowerCase();
                if (list[index].textContent.length <= 0) {
                  list[index].textContent += resultName;
              } else {
                  list[index].textContent += ', ' + resultName;
              }
                inputField.value = ''
            }
        })
  }