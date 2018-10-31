
using System;
using OSIRISGenNHibernate.EN.OSIRIS;

namespace OSIRISGenNHibernate.CAD.OSIRIS
{
public partial interface ICriticaCAD
{
CriticaEN ReadOIDDefault (int id
                          );

void ModifyDefault (CriticaEN critica);

System.Collections.Generic.IList<CriticaEN> ReadAllDefault (int first, int size);



int New_ (CriticaEN critica);

void Modify (CriticaEN critica);


void Destroy (int id
              );
}
}
