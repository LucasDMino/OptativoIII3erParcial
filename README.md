# OptativoIII3erParcial

¿Que tal profe? En este repositorio encontrará mis Scripts/Querys para la entrega de este módulo de la WEB API del 3er parcial :)
-----------------------------------------------------------------------------------------------------------------------------
Como observación, teniendo en cuenta que este parcial utiliza como base en su totalidad al parcial anterior,              
quiero resaltar que dentro de este repositorio ser encontrarán los programas que creé y/o actualicé para esta entrega,    
como por ejemplo lo es mi Program y DBContext, si desea ver la 'estructura completa' de la API, el resto de Modulos       
lo puede encontrar en mi repositorio del parcial anterior: https://github.com/LucasDMino/OptativoIII2erParcial            
-----------------------------------------------------------------------------------------------------------------------------

-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-Glorasio de contenidos-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-
* Carpeta SQL:
  - CreateTable: Query de la creación de la tabla Usuarios en mi servidor local conectado a la API.
* Carpeta C#:
  * Controllers: Carpeta contenedora de Controladores.
    - AuthController: Controlador con método Gettoken para trabajar con el user y password.
    - UsuariosController: Controlador del CRUD de Uusarios
  * Models: Carpeta contenedora de los Modelos.
    - AppDbContext:Actualizada del parcial anterior, agregado lo referente a Usuario.
    - Usuario: Get/Set correspondiente a los campos de la tabla.
  * Views: Carpeta contenedora de las Vistas.
    * Home: Vistas referentes al Home:
      - Index: Actualizado del parcial anterior, agregado lo refente a Usuario.
      - signup: Front de la parte del login para introducir el usuario y contraseña.
    * Usuario: Vistas referentes a Usuario:
      - Create
      - Delete
      - Edit
      - Index
        //Todos con la misma lógica de los CRUDs del parcial anterior
- Program: Actualizado del parcial anterior, agregado lo referente a la Tokenización.
