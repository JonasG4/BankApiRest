# TUTORIAL PARA VERSIONAR
## Clonar repositorio

Lo primero que haran sera hacer un **Fork** al repositorio. En la parte superior busquen el boton Fork y denle click.
> <img src="https://i.ibb.co/3kXC4S9/Fork.png" alt="Fork" border="0">

Fork crea una copia del repositorio original, pero como si fuera propio de su usuario, sin embargo, sigue mantiene la relacion con el repositorio original.
Esto se hace con el proposito que puedan manejar el repositorio desde su cuenta y versionar con un poco mas de seguridad. Tambien podrán notar que el tagname cambia de ***JonasG4/BankApiRest*** a ***SuNombreDeUsuario/BankApiRest.*** 
> <img src="https://i.ibb.co/JQ1cX3t/Fork-Hecho.png" alt="Fork-Hecho" border="0">

Luego de eso le dan en **Code** y copian el link del repositorio que crearon con el Fork.
> <img src="https://i.ibb.co/bgxWc43/Copiar.png" alt="Copiar" border="0">

Ahora, abran Visual Studio y seleccionen **Clonar Repositorio**.
> <img src="https://i.ibb.co/SvMhsnB/VsClone1.png" alt="VsClone1" border="0">

En el primer campo pegan el link del repositorio. El segundo campo automaticamente les creara la carpeta donde se almacenará el proyecto. Luego le dan al boton clonar. 
##### Si les llega a dar un error aquí, es porque ya existe una carpeta con el mismo nombre del proyecto que quieren crear. Solo tienen que ir a C: > Usuarios > SuUsuario > source > repos; y ahi buscan si ya hay una carpeta con el mismo nombre del repositorio. Nada más la borran y listo.  
> <img src="https://i.ibb.co/xJTJc4r/VsClone2.png" alt="VsClone2" border="0">

En caso que el explorador de soluciones les tire el proyecto de esta manera, entonces le dan click al achivo **BankApiRest.sln**
> <img src="https://i.ibb.co/vDb9R8T/VsClone3.png" alt="VsClone3" border="0">

Y, al final les quedara de esta manera el proyecto distribuido y listo para comenzar a trabajar. 
> <img src="https://i.ibb.co/yhzBZJp/VsClone4.png" alt="VsClone4" border="0">

## Configuraciones que son necesarias.
Antes que nada, para que no les de error de base de datos, cambien el Data Source en el appsettings.json, y reemplancen **JONAS\\SQLEXPRESS** por su servername de SQLServer
> <img src="https://i.ibb.co/QDW0W5M/imagen-2021-06-08-033031.png" alt="imagen-2021-06-08-033031" border="0">

Tambien, no olviden establecer el WebAPI como **Proyecto de arranque**. En el explorador de soluciones vayan a ***Presentation*** > ***WebAPI {Click Derecho}*** > ***Establecer como proyecto de arranque***
> <img src="https://i.ibb.co/9g3HPSX/imagen-2021-06-08-230018.png" alt="imagen-2021-06-08-230018" border="0">

## Hacer Push

