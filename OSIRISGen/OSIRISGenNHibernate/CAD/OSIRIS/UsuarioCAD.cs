
using System;
using System.Text;
using OSIRISGenNHibernate.CEN.OSIRIS;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using OSIRISGenNHibernate.EN.OSIRIS;
using OSIRISGenNHibernate.Exceptions;


/*
 * Clase Usuario:
 *
 */

namespace OSIRISGenNHibernate.CAD.OSIRIS
{
public partial class UsuarioCAD : BasicCAD, IUsuarioCAD
{
public UsuarioCAD() : base ()
{
}

public UsuarioCAD(ISession sessionAux) : base (sessionAux)
{
}



public UsuarioEN ReadOIDDefault (int id
                                 )
{
        UsuarioEN usuarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Get (typeof(UsuarioEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OSIRISGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OSIRISGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuarioEN;
}

public System.Collections.Generic.IList<UsuarioEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(UsuarioEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<UsuarioEN>();
                        else
                                result = session.CreateCriteria (typeof(UsuarioEN)).List<UsuarioEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OSIRISGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OSIRISGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (UsuarioEN usuario)
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioEN usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), usuario.Id);
                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OSIRISGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OSIRISGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (UsuarioEN usuario)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (usuario);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OSIRISGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OSIRISGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuario.Id;
}

public void Modify (UsuarioEN usuario)
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioEN usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), usuario.Id);
                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OSIRISGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OSIRISGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int id
                     )
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioEN usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), id);
                session.Delete (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is OSIRISGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new OSIRISGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
