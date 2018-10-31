
using System;
using OSIRISGenNHibernate.EN.OSIRIS;

namespace OSIRISGenNHibernate.CAD.OSIRIS
{
public partial interface IClienteCAD
{
ClienteEN ReadOIDDefault (int id
                          );

void ModifyDefault (ClienteEN cliente);

System.Collections.Generic.IList<ClienteEN> ReadAllDefault (int first, int size);



int New_ (ClienteEN cliente);

void Modify (ClienteEN cliente);


void Destroy (int id
              );
}
}
