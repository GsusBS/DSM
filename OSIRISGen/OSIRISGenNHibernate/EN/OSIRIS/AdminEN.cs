
using System;
// Definición clase AdminEN
namespace OSIRISGenNHibernate.EN.OSIRIS
{
public partial class AdminEN                                                                        : OSIRISGenNHibernate.EN.OSIRIS.UsuarioEN


{
/**
 *	Atributo producto
 */
private System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.ProductoEN> producto;






public virtual System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.ProductoEN> Producto {
        get { return producto; } set { producto = value;  }
}





public AdminEN() : base ()
{
        producto = new System.Collections.Generic.List<OSIRISGenNHibernate.EN.OSIRIS.ProductoEN>();
}



public AdminEN(int id, System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.ProductoEN> producto

               )
{
        this.init (Id, producto);
}


public AdminEN(AdminEN admin)
{
        this.init (Id, admin.Producto);
}

private void init (int id
                   , System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.ProductoEN> producto)
{
        this.Id = id;


        this.Producto = producto;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        AdminEN t = obj as AdminEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
