using Agate.MVC.Base;
using Agate.MVC.Core;
using System.Collections;

namespace Sapi.SpaceInvader.Boot
{
    public class GameMain : BaseMain<GameMain>, IMain
    {
        protected override IConnector[] GetConnectors()
        {
            return null;
        }

        protected override IController[] GetDependencies()
        {
            return null;
        }

        protected override IEnumerator StartInit()
        {
            yield return null;
        }
    }
}