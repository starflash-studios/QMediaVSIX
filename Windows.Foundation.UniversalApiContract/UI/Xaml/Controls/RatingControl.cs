// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.RatingControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a control that lets a user enter a star rating.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Composable(typeof (IRatingControlFactory), CompositionType.Public, 327680, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Static(typeof (IRatingControlStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class RatingControl : Control, IRatingControl
  {
    /// <summary>Initializes a new instance of the RatingControl class.</summary>
    [MethodImpl]
    public extern RatingControl();

    /// <summary>Gets or sets the text label for the control.</summary>
    /// <returns>The text label for the control. The default is an empty string.</returns>
    public extern string Caption { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the initial set rating value.</summary>
    /// <returns>The initial set rating value. The default is 1.</returns>
    public extern int InitialSetValue { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the value that determines if the user can remove the rating.</summary>
    /// <returns>**true** if the user can remove the rating; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsClearEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the value that determines if the user can change the rating.</summary>
    /// <returns>**true** if the rating is read-only; otherwise, **false**. The default is **false**.</returns>
    public extern bool IsReadOnly { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum allowed rating value.</summary>
    /// <returns>The maximum allowed rating value. The default is 5.</returns>
    public extern int MaxRating { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the rating that is displayed in the control until the value is changed by a user action or some other operation.</summary>
    /// <returns>The rating that is displayed in the control when no value is entered. The default is **null**.</returns>
    public extern double PlaceholderValue { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets info about the visual states of the items that represent a rating.</summary>
    /// <returns>A RatingItemInfo-derived object that contains details about the visual states of the items that represent a rating.</returns>
    public extern RatingItemInfo ItemInfo { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the rating value.</summary>
    /// <returns>The rating value. The default is **null**.</returns>
    public extern double Value { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the Value property has changed.</summary>
    public extern event TypedEventHandler<RatingControl, object> ValueChanged;

    /// <summary>Identifies the Caption dependency property.</summary>
    /// <returns>The identifier for Caption dependency property.</returns>
    public static extern DependencyProperty CaptionProperty { [MethodImpl] get; }

    /// <summary>Identifies the InitialSetValue dependency property.</summary>
    /// <returns>The identifier for InitialSetValue dependency property.</returns>
    public static extern DependencyProperty InitialSetValueProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsClearEnabled dependency property.</summary>
    /// <returns>The identifier for IsClearEnabled dependency property.</returns>
    public static extern DependencyProperty IsClearEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsReadOnly dependency property.</summary>
    /// <returns>The identifier for IsReadOnly dependency property.</returns>
    public static extern DependencyProperty IsReadOnlyProperty { [MethodImpl] get; }

    /// <summary>Identifies the MaxRating dependency property.</summary>
    /// <returns>The identifier for MaxRating dependency property.</returns>
    public static extern DependencyProperty MaxRatingProperty { [MethodImpl] get; }

    /// <summary>Identifies the PlaceholderValue dependency property.</summary>
    /// <returns>The identifier for PlaceholderValue dependency property.</returns>
    public static extern DependencyProperty PlaceholderValueProperty { [MethodImpl] get; }

    /// <summary>Identifies the ItemInfo dependency property.</summary>
    /// <returns>The identifier for ItemInfo dependency property.</returns>
    public static extern DependencyProperty ItemInfoProperty { [MethodImpl] get; }

    /// <summary>Identifies the Value dependency property.</summary>
    /// <returns>The identifier for Value dependency property.</returns>
    public static extern DependencyProperty ValueProperty { [MethodImpl] get; }
  }
}
