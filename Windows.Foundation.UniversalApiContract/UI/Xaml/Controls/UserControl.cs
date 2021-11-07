// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.UserControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides the base class for defining a new control that encapsulates related existing controls and provides its own logic.</summary>
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IUserControlFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [global::Windows.UI.Xaml.Markup.ContentProperty(Name = "Content")]
  [Static(typeof (IUserControlStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public class UserControl : Control, IUserControl
  {
    /// <summary>Initializes a new instance of the UserControl class.</summary>
    [MethodImpl]
    public extern UserControl();

    /// <summary>Gets or sets the content that is contained within a user control.</summary>
    /// <returns>The content of the user control.</returns>
    public extern UIElement Content { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Content dependency property.</summary>
    /// <returns>The identifier for the Content dependency property.</returns>
    public static extern DependencyProperty ContentProperty { [MethodImpl] get; }
  }
}
