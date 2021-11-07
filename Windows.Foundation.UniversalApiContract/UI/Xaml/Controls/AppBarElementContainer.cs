// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.AppBarElementContainer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a container that allows an element that doesn't implement ICommandBarElement to be displayed in a command bar.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IAppBarElementContainerFactory), CompositionType.Public, 458752, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  [Static(typeof (IAppBarElementContainerStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class AppBarElementContainer : 
    ContentControl,
    IAppBarElementContainer,
    ICommandBarElement,
    ICommandBarElement2
  {
    /// <summary>Initializes a new instance of the AppBarElementContainer class.</summary>
    [MethodImpl]
    public extern AppBarElementContainer();

    /// <summary>Gets or sets a value that indicates whether the element is shown in its compact state.</summary>
    /// <returns>**true** if the element is shown in its compact state; otherwise, **false**. The default is **false**.</returns>
    public extern bool IsCompact { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates whether this item is in the overflow menu.</summary>
    /// <returns>**true** if this item is in the overflow menu; otherwise, **false**.</returns>
    public extern bool IsInOverflow { [MethodImpl] get; }

    /// <summary>Gets or sets the order in which this item is moved to the CommandBar overflow menu.</summary>
    /// <returns>The order in which this item is moved to the overflow menu relative to other items.</returns>
    public extern int DynamicOverflowOrder { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the IsCompact dependency property.</summary>
    /// <returns>The identifier for the IsCompact dependency property.</returns>
    public static extern DependencyProperty IsCompactProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsInOverflow dependency property.</summary>
    /// <returns>The identifier for the IsInOverflow dependency property.</returns>
    public static extern DependencyProperty IsInOverflowProperty { [MethodImpl] get; }

    /// <summary>Identifies the DynamicOverflowOrder dependency property.</summary>
    /// <returns>The identifier for the DynamicOverflowOrder dependency property.</returns>
    public static extern DependencyProperty DynamicOverflowOrderProperty { [MethodImpl] get; }
  }
}
