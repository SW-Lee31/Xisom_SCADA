using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;

using Xisom.Scada.Model;
using Xisom.Scada.Core;

namespace Xisom.Vendor.Sample
{
	/// <summary>
	/// Main form.
	/// </summary>
	public partial class MainForm : Form
	{
        protected delegate void BindDelegate(IDataTag tag);

		/// <summary>
		/// 생성자
		/// </summary>
		public MainForm() {
			InitializeComponent();
		}

#region "Override"

		/// <summary>
		/// Raises the load event.
		/// </summary>
		protected override void OnLoad(EventArgs e) {
			base.OnLoad(e);
			try 
            {
                InitBrowser();
                InitTag();
			} catch (Exception exp) {
                Trace.WriteLine(exp.GetStackTrace());
                MessageBox.Show(exp.GetStackTrace());
			}
		}

#endregion

        /// <summary>
        /// HMI 화면 출력
        /// </summary>
        private void InitBrowser()
        {
            if (Program.document == null) return;
            scadaBrowser1.Navigate(Program.document.Pages[0]);
        }

        /// <summary>
        /// 태그 이벤트 등록
        /// </summary>
        private void InitTag()
        {
            try
            {
                if (Program.document == null) return;

                foreach (var item in Program.document.Tags)
                {
                    if (item.IsGroup())
                    {
                        if (item.Name.ToUpper().StartsWith("_SYSTEM")) continue;
                        if (item.Name.ToUpper().StartsWith("_DEVICES")) continue;
                        if (item.Name.ToUpper().StartsWith("_ALARMS")) continue;
                        if (item.Name.ToUpper().StartsWith("CMD")) continue;

                        var tags = Program.document.Tags.GetByFullName(item.Name);
                        foreach (var tag in tags.Children)
                        {
							if (tag.IsGroup()) 
							{
								continue;
							}
							
                            tag.LiveChanged += tag_LiveChanged;
                        }
                    }
                    else
                    {
                        item.LiveChanged += tag_LiveChanged;
                    }
                }
            }
            catch (Exception exp)
            {
                Trace.WriteLine(exp.GetStackTrace());
                MessageBox.Show(exp.GetStackTrace());
            }
        }

        /// <summary>
        /// 태그 LiveChanged 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tag_LiveChanged(object sender, EventArgs e)
        {
            IDataTag tag = sender as IDataTag;
            Debug.WriteLine(string.Format("DateTime:{0}      tagName:{1}     tagValue:{2}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), tag.Name, tag.Value));

            BindData(tag);

            #region - 태그 전체 목록 가져오기 예시
            //  Program.document.Tags
            #endregion

            #region - 태그 이벤트 등록 예시

            // 유의사항: group tag에 대해서는 event 등록 불가
            //
            //  foreach (var item in Program.document.Tags)
            //  {
            //      if (item.IsGroup())
            //      {
            //          var tags = Program.document.Tags.GetByFullName(item.Name);
            //          foreach (var tag in tags.Children)
            //          {
            //              tag.LiveChanged += tag_LiveChanged;
            //          }
            //      }
            //      else
            //      {
            //          item.LiveChanged += tag_LiveChanged;
            //      }
            //  }

            #endregion

            #region - 태그 정보 가져오기 예시

            //태그 기본 정보
            //  tag.Name;           태그명 (그룹 제외)
            //  tag.FullName;       태그 FullName (그룹 포함)
            //  tag.Desc;           태그설명
            //  tag.Value;          태그값 - object
            //  tag.StringValue;    태그값 - string
            //  tag.BoolValue;      태그값 - bool
            //  tag.DoubleValue;    태그값 - double

            //Tag 종류에 대한 세부속성 정보
            //  tag as IStringTag
            //  tag as IDigitalTag
            //  tag as IAnalogTag
            //
            //  if (tag.IsAnalog()) 
            //  {
            //      IAnalogTag analog = tag as IAnalogTag;
            //  }
            //  else if (tag.IsDigital())
            //  {
            //      IDigitalTag digital = tag as IDigitalTag;
            //  }
            //  else if (tag.IsString())
            //  {
            //      IStringTag ss = tag as IStringTag;
            //  }
            //  else if (tag.IsGroup())
            //  {
            //      foreach (var item in tag.Children)
            //      {
            //      }
            //  }

            #endregion

            #region - 태그 값 쓰기 예시

            //tagname = "OP10.digital_1";
            //tag = Program.document.Tags.GetByFullName(tagname);
            //tag.Value = 100;

            #endregion

            #region - device 정보 가져오기 예시

            //Deviec 정보
            //  var device = tag.Device as IDevice;
            //  device.IsAlive 
            //  device.Name

            //Device에 대한 Network 정보
            //  var network = device.Connections[0] as INetworkConnection;
            //  network.RemoteAddress

            #endregion

        }

        /// <summary>
        /// 데이터 출력
        /// </summary>
        /// <param name="tag"></param>
        private void BindData(IDataTag tag)
        {
            if (InvokeRequired)
            {
                BindDelegate pDelegate = new BindDelegate(BindData);
                BeginInvoke(pDelegate, tag);
            }
            else
            {
                try
                {
                    if (tag == null) return;

                    tagNameTextBox.Text = tag.FullName;
                    tagValTextBox.Text  = tag.Value.ToString();
                }
                catch (Exception exp)
                {
                    Debug.WriteLine(exp.GetStackTrace());
                }
            }
        }


        /// <summary>
        /// 디바이스 상태 폼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void channelButton_Click(object sender, EventArgs e)
        {
            if (GetForm(typeof(ChannelStatusForm)) != null) return;

            ChannelStatusForm form = new ChannelStatusForm();
            form.Document = Program.document;
            form.Show(this);
        }

        /// <summary>
        /// 태그 상태 폼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tagButton_Click(object sender, EventArgs e)
        {
            if (GetForm(typeof(TagStatusForm)) != null) return;

            TagStatusForm form = new TagStatusForm();
            form.Document = Program.document;
            form.Show(this);
        }

        private Form GetForm(Type type)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.IsDisposed == false && f.GetType() == type)
                {
                    return f;
                }
            }
            return null;
        }

        private void tagSentButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Program.document == null) return;

                var tagName = tagNameTextBox.Text.Trim();
                var tagValue = tagSentTextBox.Text.Trim();

                var tag = Program.document.Tags.GetByFullName(tagName);
                tag.Value = tagValue;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.GetStackTrace());
            }
        }
	}
}

