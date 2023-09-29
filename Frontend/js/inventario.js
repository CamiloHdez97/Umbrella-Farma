function agregarProducto() {
  const nombre = document.getElementById("nombre").value;
  const cantidad = document.getElementById("cantidad").value;

  const lista = document.getElementById("inventario-lista");
  const listItem = document.createElement("li");
  listItem.innerHTML = `<span>${nombre}</span> <span>${cantidad} unidades</span>`;
  lista.appendChild(listItem);

  // Limpiar los campos del formulario
  document.getElementById("nombre").value = "";
  document.getElementById("cantidad").value = "";
}