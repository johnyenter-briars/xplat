using Avalonia;
using Avalonia.Controls.Primitives;

namespace XPlat.Controls;

public class LargeLabelControl : TemplatedControl
{

	/// <summary>
	/// IsCapable StyledProperty definition
	/// </summary>
	public static readonly StyledProperty<string> LargeTextProperty =
		AvaloniaProperty.Register<LargeLabelControl, string>(nameof(LargeText), "LARGE TEXT");

	/// <summary>
	/// Gets or sets the IsCapable property. This StyledProperty
	/// indicates ....
	/// </summary>
	public string LargeText
	{
		get => this.GetValue(LargeTextProperty);
		set => SetValue(LargeTextProperty, value);
	}

	/// <summary>
	/// IsCapable StyledProperty definition
	/// </summary>
	public static readonly StyledProperty<string> SmallTextProperty =
		AvaloniaProperty.Register<LargeLabelControl, string>(nameof(SmallText), "SMALL TEXT");

	/// <summary>
	/// Gets or sets the IsCapable property. This StyledProperty
	/// indicates ....
	/// </summary>
	public string SmallText
	{
		get => this.GetValue(SmallTextProperty);
		set => SetValue(SmallTextProperty, value);
	}




}