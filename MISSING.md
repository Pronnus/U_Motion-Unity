# Missing

- Poner bien los nombres en el custom Inspector del transform, pero poiendo la label, NO cambiar el nombre de la propiedad porque se borran los valores !! 
- Falta poner el campo para el Transform en el componente TweenTransform
- Poner la opcion para desde el editor con un enum seleccionar el tipo de curva de tiempo, o crear una vurva de tiempo una opcion de custon o algo asi
- Hacer la opcion de destroy animation pasando un gameobject y que las destruya, por nombre o todas
- Que si no se especifica un valor inicial, este valor inicial sea el que tiene la variable en el momento 0 antes de animar
- Ver si hay una opcion , para que solo se pueda seleccionar un porcentaje una vez, asi como 100% una vez, y que no se puedan seleccionar numeros mayores o menores a 0-100
- Hacer una maquina de estados para las animaciones, que por ejemplo el componente tenga x estados y tenga x animaciones,
   cada que el estado cambie, se van a poner playy a las animaciones que tengan el estado actual y se pondra ausa a las animaciones que tengan un 
   estado pasado, las animaciones podran ser destruidas, asi que hara verificacion de si existen antes de ponerles play.
   Un caso de uso, es por ejemplo para los botones, se pone el estado "pressed", o "Clicked , etc.. ".

- Hacer que las animaciones tengan un nombre, pero que solo se muestre, que no se puedaa editar


- Quitar los comentarios que puse para lo de ver la sincronizacion

- Quitar el campo script del siguiente
TimeAnimatorCoreInspectorExtension
Y poner como se hace en mis guias

- Para los FloatAnimators y eso, que se ven solo cuando esta play, poner campos que representen el porcentaje de la animacion y si esta Play o Pause y todo eso,
Solo para mas claridad