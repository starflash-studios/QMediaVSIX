// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.DependencyObject
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Xaml
{
  /// <summary>Represents an object that participates in the dependency property system. DependencyObject is the immediate base class of many important UI-related classes, such as UIElement, Geometry, FrameworkTemplate, Style, and ResourceDictionary. For more info on how DependencyObject supports dependency properties, see Dependency properties overview.</summary>
  [Composable(typeof (IDependencyObjectFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public class DependencyObject : IDependencyObject, IDependencyObject2
  {
    /// <summary>Provides base class initialization behavior for DependencyObject derived classes.</summary>
    [MethodImpl]
    protected extern DependencyObject();

    /// <summary>Returns the current effective value of a dependency property from a DependencyObject.</summary>
    /// <param name="dp">The DependencyProperty identifier of the property for which to retrieve the value.</param>
    /// <returns>Returns the current effective value.</returns>
    [MethodImpl]
    public extern object GetValue(DependencyProperty dp);

    /// <summary>Sets the local value of a dependency property on a DependencyObject.</summary>
    /// <param name="dp">The identifier of the dependency property to set.</param>
    /// <param name="value">The new local value.</param>
    [MethodImpl]
    public extern void SetValue(DependencyProperty dp, object value);

    /// <summary>Clears the local value of a dependency property.</summary>
    /// <param name="dp">The DependencyProperty identifier of the property for which to clear the value.</param>
    [MethodImpl]
    public extern void ClearValue(DependencyProperty dp);

    /// <summary>Returns the local value of a dependency property, if a local value is set.</summary>
    /// <param name="dp">The DependencyProperty identifier of the property for which to retrieve the local value.</param>
    /// <returns>Returns the local value, or returns the sentinel value UnsetValue if no local value is set.</returns>
    [MethodImpl]
    public extern object ReadLocalValue(DependencyProperty dp);

    /// <summary>Returns any base value established for a dependency property, which would apply in cases where an animation is not active.</summary>
    /// <param name="dp">The identifier for the desired dependency property.</param>
    /// <returns>The returned base value.</returns>
    [MethodImpl]
    public extern object GetAnimationBaseValue(DependencyProperty dp);

    /// <summary>Gets the CoreDispatcher that this object is associated with. The CoreDispatcher represents a facility that can access the DependencyObject on the UI thread even if the code is initiated by a non-UI thread.</summary>
    /// <returns>The CoreDispatcher that DependencyObject object is associated with, which represents the UI thread.</returns>
    public extern CoreDispatcher Dispatcher { [MethodImpl] get; }

    /// <summary>Registers a notification function for listening to changes to a specific DependencyProperty on this DependencyObject instance.</summary>
    /// <param name="dp">The dependency property identifier of the property to register for property-changed notification.</param>
    /// <param name="callback">A callback based on the DependencyPropertyChangedCallback delegate, which the system invokes when the value of the specified property changes.</param>
    /// <returns>A token that represents the callback, used to identify the callback in calls to UnregisterPropertyChangedCallback.</returns>
    [MethodImpl]
    public extern long RegisterPropertyChangedCallback(
      DependencyProperty dp,
      DependencyPropertyChangedCallback callback);

    /// <summary>Cancels a change notification that was previously registered by calling RegisterPropertyChangedCallback.</summary>
    /// <param name="dp">The dependency property identifier of the property to unregister for property-changed notification.</param>
    /// <param name="token">A token that represents the callback (returned by RegisterPropertyChangedCallback ).</param>
    [MethodImpl]
    public extern void UnregisterPropertyChangedCallback(DependencyProperty dp, long token);
  }
}
