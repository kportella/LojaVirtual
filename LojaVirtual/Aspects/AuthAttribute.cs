using Metalama.Framework.Aspects;

namespace LojaVirtual.Aspects;

public class AuthAttribute : OverrideMethodAspect
{
    public override dynamic? OverrideMethod()
    {
        if (LojaVirtual.UsuarioAutenticado) return meta.Proceed();
        throw new UnauthorizedAccessException("Usuário não autenticado.");
    }
}