// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.ResourceContext
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.ApplicationModel.Resources.Core
{
  /// <summary>Encapsulates all of the factors (ResourceQualifier s) that might affect resource selection.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IResourceContextStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IResourceContextStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IResourceContextStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IResourceContextStatics4), 524288, "Windows.Foundation.UniversalApiContract")]
  public sealed class ResourceContext : IResourceContext
  {
    /// <summary>Creates a cloned ResourceContext object.</summary>
    [MethodImpl]
    public extern ResourceContext();

    /// <summary>Gets a writable, observable map of all supported qualifiers, indexed by name.</summary>
    /// <returns>The map of qualifiers, which you use to map a qualifier name to a qualifier value. The qualifier value returned represents the current setting. Here is a reference table of all the possible qualifier values that can be returned. See Tailor your resources for language, scale, high contrast, and other qualifiers for an explanation of the general concept of qualifiers, how to use them, and the purpose of each of the qualifier names.</returns>
    public extern IObservableMap<string, string> QualifierValues { [MethodImpl] get; }

    /// <summary>Resets the overridden values for all qualifiers on the given ResourceContext instance.</summary>
    [Overload("Reset")]
    [MethodImpl]
    public extern void Reset();

    [Overload("ResetQualifierValues")]
    [MethodImpl]
    public extern void Reset(IIterable<string> qualifierNames);

    [MethodImpl]
    public extern void OverrideToMatch(IIterable<ResourceQualifier> result);

    /// <summary>Creates a clone of this ResourceContext, with identical qualifiers.</summary>
    /// <returns>A new, cloned ResourceContext.</returns>
    [MethodImpl]
    public extern ResourceContext Clone();

    /// <summary>Gets or sets the language qualifier for this context.</summary>
    /// <returns>A collection of BCP-47 language tags.</returns>
    public extern IVectorView<string> Languages { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a default ResourceContext associated with the specified UIContext for the currently running application.</summary>
    /// <param name="context">The UI context for which to get the ResourceContext.</param>
    /// <returns>The default ResourceContext associated with the specified UI context.</returns>
    [MethodImpl]
    public static extern ResourceContext GetForUIContext(UIContext context);

    /// <summary>Applies a single qualifier value override to default contexts of all views for the current app, and specifies the persistence of the override.</summary>
    /// <param name="key">The name of the qualifier to override.</param>
    /// <param name="value">The override value to set.</param>
    /// <param name="persistence">The persistence of the override value.</param>
    [Overload("SetGlobalQualifierValueWithPersistence")]
    [MethodImpl]
    public static extern void SetGlobalQualifierValue(
      string key,
      string value,
      ResourceQualifierPersistence persistence);

    /// <summary>Gets a default ResourceContext associated with the current view for the currently running application.</summary>
    /// <returns>The default context associated with the current view.</returns>
    [MethodImpl]
    public static extern ResourceContext GetForCurrentView();

    /// <summary>Applies a single qualifier value override to default contexts of all views for the current app.</summary>
    /// <param name="key">The name of the qualifier to override.</param>
    /// <param name="value">The override value to set.</param>
    [Overload("SetGlobalQualifierValue")]
    [MethodImpl]
    public static extern void SetGlobalQualifierValue(string key, string value);

    /// <summary>Removes any qualifier overrides from default contexts of all views across the app.</summary>
    [Overload("ResetGlobalQualifierValues")]
    [MethodImpl]
    public static extern void ResetGlobalQualifierValues();

    [Overload("ResetGlobalQualifierValuesForSpecifiedQualifiers")]
    [MethodImpl]
    public static extern void ResetGlobalQualifierValues(IIterable<string> qualifierNames);

    /// <summary>Gets a default ResourceContext not associated with any view.</summary>
    /// <returns>A default ResourceContext not associated with any view.</returns>
    [MethodImpl]
    public static extern ResourceContext GetForViewIndependentUse();

    [MethodImpl]
    public static extern ResourceContext CreateMatchingContext(
      IIterable<ResourceQualifier> result);
  }
}
