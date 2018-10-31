
using System;
using OSIRISGenNHibernate.EN.OSIRIS;

namespace OSIRISGenNHibernate.CAD.OSIRIS
{
public partial interface IBibliotecaCAD
{
BibliotecaEN ReadOIDDefault (int id
                             );

void ModifyDefault (BibliotecaEN biblioteca);

System.Collections.Generic.IList<BibliotecaEN> ReadAllDefault (int first, int size);



int New_ (BibliotecaEN biblioteca);

void Modify (BibliotecaEN biblioteca);


void Destroy (int id
              );
}
}
