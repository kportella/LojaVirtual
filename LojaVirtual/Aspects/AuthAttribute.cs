using Metalama.Framework.Aspects;

namespace LojaVirtual.Aspects;

public class AuthAttribute : OverrideMethodAspect
{
    public override dynamic? OverrideMethod()
    {
        if (userIsAuthenticated()) return meta.Proceed();
        throw new UnauthorizedAccessException("Usuário não autenticado.");
    }

    private bool userIsAuthenticated()
    {
        return true;
    }
    
}