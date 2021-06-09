# TUTORIAL PARA VERSIONAR
## Clonar repositorio

Lo primero que haran será hacer un **Fork** al repositorio original. En la parte superior busquen el boton ``Fork`` y denle ``click``.
> <img src="https://i.ibb.co/3kXC4S9/Fork.png" alt="Fork" border="0">

Fork crea una copia del repositorio original, pero como si fuera propio de tu usuario, sin embargo, sigue manteniendo la relacion con el repositorio original.
Esto se hace con el proposito que puedan manejar el repositorio desde su cuenta y versionar con un poco mas de seguridad. Tambien podrán notar que el tagname cambia de ``JonasG4/BankApiRest`` a ``TuNombreDeUsuario/BankApiRest`` 
> <img src="https://i.ibb.co/QbBkLHh/Fork-Hecho.png" alt="Fork-Hecho" border="0">

Luego de eso le dan en ``Code`` y copian el link del repositorio que crearon con el Fork.
> <img src="https://i.ibb.co/1nN2N13/Copiar.png" alt="Copiar" border="0">

Ahora, abran Visual Studio y seleccionen ``Clonar Repositorio``
> <img src="https://i.ibb.co/SvMhsnB/VsClone1.png" alt="VsClone1" border="0">

En el primer campo pegan el link del repositorio. El segundo campo automaticamente les creara la carpeta donde se almacenará el proyecto. Luego le dan al boton ``Clonar``
##### Si les llega a dar un error aquí, es porque ya existe una carpeta con el mismo nombre del proyecto que quieren crear. Solo tienen que ir a C: > Usuarios > SuUsuario > source > repos; y ahi buscan si ya hay una carpeta con el mismo nombre del repositorio. Nada más la borran y listo.  
> <img src="https://i.ibb.co/xJTJc4r/VsClone2.png" alt="VsClone2" border="0">

En caso que el explorador de soluciones les tire el proyecto de esta manera, entonces le dan click al achivo ``BankApiRest.sln``
> <img src="https://i.ibb.co/vDb9R8T/VsClone3.png" alt="VsClone3" border="0">

Y, al final les quedara de esta manera el proyecto distribuido y listo para comenzar a trabajar. 
> <img src="https://i.ibb.co/yhzBZJp/VsClone4.png" alt="VsClone4" border="0">

## Configuraciones que son necesarias.
Antes que nada, para que no les de error de base de datos, cambien el Data Source en el appsettings.json, y reemplancen ``JONAS\\SQLEXPRESS`` por su servername de SQLServer
> <img src="https://i.ibb.co/QDW0W5M/imagen-2021-06-08-033031.png" alt="imagen-2021-06-08-033031" border="0">

Tambien, no olviden establecer el WebAPI como ``Proyecto de arranque``. En el explorador de soluciones vayan a ***Presentation*** > ***WebAPI {Click Derecho}*** > ***Establecer como proyecto de arranque***
> <img src="https://i.ibb.co/9g3HPSX/imagen-2021-06-08-230018.png" alt="imagen-2021-06-08-230018" border="0">

## Configurar repositorios remotos
Ahora configuraremos git para que podamos versionar nuestro proyecto a nuestro repositorio Fork o al repositorio Original. Para eso nos iremos al menu **Git** > *Administrar remoto*
> <img src="https://i.ibb.co/VH7x4Tf/Gestor-Remoto.png" alt="Gestor-Remoto" border="0">

Nos aparecera esta ventana, donde veremos que solo tenemos un lugar a donde versionar y ese es el repositorio Fork. 
> <img src="https://i.ibb.co/ZJf62WH/Gestor-Remoto2.png" alt="Gestor-Remoto2" border="0">

Primero, cambiaremos el nombre de la locacion, para ello primero seleccionen ``Origin`` y luego le damos Editar. 
> <img src="https://i.ibb.co/PGmHk8r/Gestor-Remoto4.png" alt="Gestor-Remoto4" border="0">

Les aparecerá esta ventana. En el campo ``Nombre`` cambienlo a ``Fork``, y denle ``Guardar``. 
> <img src="https://i.ibb.co/FHd4GmH/Gestor-Remoto5.png" alt="Gestor-Remoto5" border="0">

Ahora crearemos la locacion para el repositorio Original. En esta ventana le damos Add/Agregar. 
> <img src="https://i.ibb.co/djFMWkw/Gestor-Remoto6.png" alt="Gestor-Remoto6" border="0">

Nos volverá a mostrar la misma ventana anterior. En nombre le colocamos ``Origin`` y en el campo de abajo colocaremos el link del repositorio original. 
`` https://github.com/JonasG4/BankApiRest.git`` y le daremos ``Guardar``.
> <img src="https://i.ibb.co/v1KM3Yw/Gestor-Remoto7.png" alt="Gestor-Remoto7" border="0">

Nos debe quedar de esta manera. Si todo esta bien, le damos ``Aceptar``
> <img src="https://i.ibb.co/qR7sCXJ/imagen-2021-06-09-021113.png" alt="imagen-2021-06-09-021113" border="0">

## Usar Branch o Ramas
Los Branch o las ramas son las que nos ayudaran a controlar las versiones por usuario. De modo en que todo el codigo este ordenado y no se mezclen de manera caótica.
Para ello nos iremos al menú ***Git*** > *** Nueva rama***
> <img src="https://i.ibb.co/B2f8RKw/New-Branch.png" alt="New-Branch" border="0">

Aparecera esta ventana emergente, en ella colocaremos el nombre de la rama en este caso coloquen su nombre seguido de Branch, EJP: ``JonasBranch``
Se aseguran que este marcada la casilla de ``Checkout branch`` y le dan ``Crear``
> <img src="https://i.ibb.co/ydmPkzB/Crear-Branch.png" alt="Crear-Branch" border="0">

Ahora, ¿como sabremos en que Branch estamos? Usualmente siempre hay una rama llamada ``master`` o ``main`` que se crea por defecto. Podremos saberlo por la linea inferior azul de nuestro Visual Studio.
> <img src="https://i.ibb.co/0h5V9Q2/En-Que-Branch-Estoy.png" alt="En-Que-Branch-Estoy" border="0">

##### Si observan la primera imagen de este tema, notaran que primero estabamos en la rama master, pero haciendo uso de ``Checkout`` nos movimos a la rama que creamos. 
