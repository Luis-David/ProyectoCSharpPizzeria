# ProyectoCSharpPizzeria
Proyecto de gestión de pedidos de una pizzería

## Autores:
- Luis David Barragán Ramírez
- Oscar Ignacio Vásquez
- Damian Matuz Cristino

## Introducción

La Pizzeria El Becario

Nuestro proyecto versa sobre un sistema informático para la gestión de ordenes de una pizzeria (El becario), este sistema será operado por personal de la pizzeria para tomar los pedidos de los clientes. Consta de un menu principal cuyas secciones son: 

-Nueva Orden: En esta sección se crean las ordenes dandole a escoger al operador el tamaño de la pizza, la especilidad y agregar un refresco de diferentes tamaños y marcas, aqui se puede escoger tanto la cantidad de pizzas como la cantidad de refrescos que llevará la orden. El operador podrá ver un cuandro con la descripción de los productos seleccionados para la orden para confirmar que son correctos para posteriormente finalizar la orden, al finalizar la orden se genera un número de ficha que contiene toda la información del pedido.

-Consultar Orden: Para consultar las ordenes se debe ingresar el número de ficha que se genero al finalizar la orden, se muestra una descripción de los productos, la fecha, la hora y el total de la orden.

-Ver todas las ordenes: Aqui se listan todas las ordenes previamente generadas

-Ampliar catálogo: En esta parte se puede ampliar el catalogo de pizzas o refrescos que se van a vender, con el fin de estar siempre actualizado con las especilidades más solicitadas por los clientes.

-Creditos: Aqui se visualizan los autores del sistema.

## IMPORTANTE

Antes de ejecutar el proyecto en Visual Studio se debe de realizar las siguientes
instrucciones:

Instalar postgresql 11.7:
	https://www.enterprisedb.com/thank-you-downloading-postgresql?anid=1257367
El usuario que debe tener la base de datos es "postgres", la contraseña debe ser "hola123.,"
 y el puerto de la base de datos es el default 5432.

Una vez que ya tenemos instalada la base de datos postgresql, iremos a nuestro proyecto
en Visual Studio e iremos a esta ruta Tools->NuGet Package Manage->Manage NuGet Packages for solutios...
 así como se muestra en la siguiente imagen:

![archivo](img/0.png  "NuGet")

Despues debemos escribir postgres y seleccionar el driver Npgsql y lo instalamos,
la siguiente imagen ilustra lo anterior:

![archivo](img/1.PNG  "NuGet2")


Ahora necesitamos importar la base de datos pizzeria, para esto
es necesario abrir PGAdmin y crear una base de datos con el nombre "pizzeria",
seleccionamos nuestra nueva base de datos, le damos click derecho y seleccionamos
restor, así como se muestra en la siguiente imagen:

![archivo](img/2.png  "BD")

Tendremos que seleccionar el archivo backupPizzas.backup y selecionar el rol postgres,
así como se muestra en la siguiente imagen:

![archivo](img/3.png  "BD2")


