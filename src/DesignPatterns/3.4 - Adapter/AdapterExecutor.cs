using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter
{
    public class AdapterExecutor
    {
        public static void Execute()
        {
            var transacaoService = new TransacaoService(new Logger());
            transacaoService.ExecutarTransacao();

            var logNetMasterService = new TransacaoService(new LoggerAdapter(new LogNetMasterService()));
            logNetMasterService.ExecutarTransacao();
        }        
    }
}
