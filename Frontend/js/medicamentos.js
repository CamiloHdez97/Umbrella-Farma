const apiUrl = 'http://localhost:5000/api/Medicine';  // Reemplaza con la URL de tu API
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
  
  
//http://localhost:5000/api/Medicine

  // {
    //   "creationDate": "2022-12-21T00:00:00",
    //   "expirationDate": "2025-01-20T00:00:00",
    //   "inventoryId": 5,
    //   "stateId": 4
    // }