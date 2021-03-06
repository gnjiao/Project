﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project
{
	public partial class MoveDisControl : UserControl
	{

		public AxisConfig arrAxis; //定义一个AxisConfig的对象
		public int num = 0;
		public MoveDisControl()
		{
			InitializeComponent();

		}

		public MoveDisControl(AxisConfig arrAxis_)  //初始化轴参数数组
		{
			arrAxis = arrAxis_;
			InitializeComponent();



		}


		private double _distance = 0; //距离设置
		public double distance
		{
			get { return Convert.ToDouble(PointDistance.Value); }
			set { distance = value; }
		}

		private void SetP_Distance_Load(object sender, EventArgs e)
		{
			if (arrAxis != null)
			{

				// PointDistance.Value = new decimal(_distance);
			}

		}

		private void PointDistance_ValueChanged(object sender, EventArgs e)
		{
			switch (StationManage.Distancemode)
			{
				case "短距":
					PointDistance.Increment = 1;

					StationManage.Shortdistanceset = Convert.ToDouble(PointDistance.Value);


					break;

				case "长距":

					PointDistance.Increment = 5;

					StationManage.Longdistanceset = Convert.ToDouble(PointDistance.Value);


					break;

			}

		}

		public void RefrshLoadValue()
		{

			switch (StationManage.Distancemode)
			{

				case "短距":

					PointDistance.Value = new System.Decimal(StationManage.Shortdistanceset);




					break;

				case "长距":

					PointDistance.Value = new System.Decimal(StationManage.Longdistanceset);


					break;

			}



		}

	}
}
