
using System;
// Definición clase ProductoEN
namespace OSIRISGenNHibernate.EN.OSIRIS
{
public partial class ProductoEN
{
/**
 *	Atributo categoria
 */
private System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.CategoriaEN> categoria;



/**
 *	Atributo cesta
 */
private System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.CestaEN> cesta;



/**
 *	Atributo comentario
 */
private System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.ComentarioEN> comentario;



/**
 *	Atributo critica
 */
private System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.CriticaEN> critica;



/**
 *	Atributo biblioteca
 */
private System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.BibliotecaEN> biblioteca;



/**
 *	Atributo admin
 */
private System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.AdminEN> admin;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo nombre
 */
private string nombre;






public virtual System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.CategoriaEN> Categoria {
        get { return categoria; } set { categoria = value;  }
}



public virtual System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.CestaEN> Cesta {
        get { return cesta; } set { cesta = value;  }
}



public virtual System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.ComentarioEN> Comentario {
        get { return comentario; } set { comentario = value;  }
}



public virtual System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.CriticaEN> Critica {
        get { return critica; } set { critica = value;  }
}



public virtual System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.BibliotecaEN> Biblioteca {
        get { return biblioteca; } set { biblioteca = value;  }
}



public virtual System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.AdminEN> Admin {
        get { return admin; } set { admin = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}





public ProductoEN()
{
        categoria = new System.Collections.Generic.List<OSIRISGenNHibernate.EN.OSIRIS.CategoriaEN>();
        cesta = new System.Collections.Generic.List<OSIRISGenNHibernate.EN.OSIRIS.CestaEN>();
        comentario = new System.Collections.Generic.List<OSIRISGenNHibernate.EN.OSIRIS.ComentarioEN>();
        critica = new System.Collections.Generic.List<OSIRISGenNHibernate.EN.OSIRIS.CriticaEN>();
        biblioteca = new System.Collections.Generic.List<OSIRISGenNHibernate.EN.OSIRIS.BibliotecaEN>();
        admin = new System.Collections.Generic.List<OSIRISGenNHibernate.EN.OSIRIS.AdminEN>();
}



public ProductoEN(int id, System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.CategoriaEN> categoria, System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.CestaEN> cesta, System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.ComentarioEN> comentario, System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.CriticaEN> critica, System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.BibliotecaEN> biblioteca, System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.AdminEN> admin, string nombre
                  )
{
        this.init (Id, categoria, cesta, comentario, critica, biblioteca, admin, nombre);
}


public ProductoEN(ProductoEN producto)
{
        this.init (Id, producto.Categoria, producto.Cesta, producto.Comentario, producto.Critica, producto.Biblioteca, producto.Admin, producto.Nombre);
}

private void init (int id
                   , System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.CategoriaEN> categoria, System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.CestaEN> cesta, System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.ComentarioEN> comentario, System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.CriticaEN> critica, System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.BibliotecaEN> biblioteca, System.Collections.Generic.IList<OSIRISGenNHibernate.EN.OSIRIS.AdminEN> admin, string nombre)
{
        this.Id = id;


        this.Categoria = categoria;

        this.Cesta = cesta;

        this.Comentario = comentario;

        this.Critica = critica;

        this.Biblioteca = biblioteca;

        this.Admin = admin;

        this.Nombre = nombre;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ProductoEN t = obj as ProductoEN;
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
