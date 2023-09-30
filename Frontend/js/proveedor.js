const apiUrl = 'http://localhost:5000/api/Supplier';  // Reemplaza con la URL de tu API
const token = 'tu-token';  // Reemplaza con tu token

fetch(apiUrl, {
  method: 'GET',
  headers: {
//    'Authorization': Bearer ${token},
    'Content-Type': 'application/json'
  }
})
  .then(response => {
    if (!response.ok) {
      throw new Error('Network response was not ok');
    }
    return response.json();
  })
  .then(data => {
    // Aquí guardas la lista de objetos y la iteras
    const objectList = data;  // Suponiendo que la respuesta es una lista de objetos
    objectList.forEach(obj => {
      console.log(obj);  // Haz algo con cada objeto, por ejemplo, imprimirlo en la consola
    });
  })
  .catch(error => console.error('Error:', error));