using Momo.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Momo
{
    public partial class Momo : ServiceBase
    {
        private static log4net.ILog _logger =

log4net.LogManager.GetLogger(
System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        //Timer作成
        private System.Threading.Timer _timer;
        private Random _random = new Random();

        public Momo()
        {
            InitializeComponent();

            //コンストラクタ内でTimerインスタンス化
            _timer = new System.Threading.Timer(
                //コールバックの設定
                Timer_Callback,
                null,
                //止める処理
                Timeout.Infinite,
                Timeout.Infinite);
                
                
        }

        protected override void OnStart(string[] args)
        {
            _logger.Info("スタートしました！！");
            //0秒スタートの1秒間隔でスタート
            _timer.Change(0, 1000);
        }

        protected override void OnStop()
        {
            _logger.Info("ストップしました！！");
        }

        internal void DebagRun()
        {
            OnStart(null);
            Console.ReadLine();
            OnStop();
        }

        private void Timer_Callback(object obj)
        {
            try
            {
                _logger.Info("コールバックです！！！！");
                var measure = new MeasureSQLServer();
                measure.Insert(
                    DateTime.Now, 
                    Convert.ToSingle(_random.NextDouble()));
            }
            catch (Exception ex)
            {

                _logger.Error("Timer_Callback error!!!", ex);
            }
        }
    }
}
