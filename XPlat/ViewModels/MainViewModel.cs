using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace XPlat.ViewModels;
internal partial class MainViewModel : ObservableObject
{
	[ObservableProperty]
	private string boldTitle = "Avalonia";

	[ObservableProperty]
	private string regularTitle = "Loudness Meter";
}
