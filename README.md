# TaskBarProgressBar
Agrega la barra de progreso en tu programa en la barra de tareas de Windows.

## Como usar con referencia
Primero agrega las siguientes referencias a tu proyecto (OJO: Es posible que se te pida importar otras mas):

- TaskBarProgressBar.dll
- Microsoft.WindowsAPICodePack.dll
- Microsoft.WindowsAPICodePack.Shell.dll

Segundo: Importa la libreria en tu codigo:

- (VB): Imports TrackBarProgressBarVB
- (C#): Using TrackBarProgressBarC_;

Tercero: En tu evento Load o en cualquier lugar de tu codigo, agrega lo siguiente:

- (VB): TaskBarProgressBar.SetState(state, Me)
- (C#): TaskBarProgressBar.SetState(state, This);

state sera el estado en el cual quieres que se vea la barra de progreso. Los tipos de estados se veran a continuacion:

## Tipos de estados
Las 5 formas en las cuales se puede ver la barra de progreso:

- 1- None (No muestra la barra de progreso)
- 2- Normal (Muestra la tipica barra verde de progreso)
- 3- Pause (Muestra la barra de progreso de color amarillo)
- 4- Error (Muestra la barra de progreso de color rojo)
- 5- Undefined (Muestra la barra de progreso de color verde, ademas de una animacion tipo carga)

Nota: Undefined no sera afectada por el valor

## Agregar un valor
Para agregar un valor a la barra de progreso, estan las unicas dos formas:

Forma 1:
- (VB): TaskBarProgressBar.SetProgress(value, maxvalue)
- (C#): TaskBarProgressBar.SetProgress(value, maxvalue);

En la forma 1, value sera el valor que tendra la barra de progreso, mientras que maxvalue, sera el valor maximo a la cual puede llegar esa barra.

Forma 2:
- (VB): TaskBarProgressBar.SetProgress(value, maxvalue, form, state)
- (C#): TaskBarProgressBar.SetProgress(value, maxvalue, form, state)

En esta forma no sera necesario usar SetState(), ya que en esta viene incluida. 
value sera el valor que quieres que tenga la barra, maxvalue sera el valor maximo al que puede llegar la barra, form es el formulario en el cual quieres mostrar la barra, state sera el estado que tendra la barra de progreso.

# Como usar sin la referencia TaskBarProgressBar
En este caso solo tienes que importar en tu proyecto:

- Microsoft.WindowsAPICodePack.dll
- Microsoft.WindowsAPICodePack.Shell.dll

Luego copia todo el codigo que esta en la clase class1 dependiendo el lenguaje que necesites

- (VB): TaskBarProgressBar/class1.vb
- (C#): TaskBarProgressBarC#/class1.cs

Espero que este proyectito te sea de mucha ayuda :3
