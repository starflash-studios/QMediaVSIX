// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionObject
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.UI.Core;

namespace Windows.UI.Composition
{
  /// <summary>Base class of the composition API representing a node in the visual tree structure.</summary>
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (ICompositionObjectFactory), CompositionType.Public, 131072, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ICompositionObjectStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [DualApiPartition(version = 167772164)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public class CompositionObject : 
    ICompositionObject,
    ICompositionObject2,
    ICompositionObject3,
    ICompositionObject4,
    IClosable,
    IAnimationObject
  {
    /// <summary>The Compositor used to create this CompositionObject.</summary>
    /// <returns>The Compositor used to create this CompositionObject.</returns>
    public extern Compositor Compositor { [MethodImpl] get; }

    /// <summary>The dispatcher for the CompositionObject.</summary>
    /// <returns>The dispatcher for the CompositionObject.</returns>
    public extern CoreDispatcher Dispatcher { [MethodImpl] get; }

    /// <summary>The collection of properties associated with the CompositionObject.</summary>
    /// <returns>The collection of properties associated with the CompositionObject.</returns>
    public extern CompositionPropertySet Properties { [MethodImpl] get; }

    /// <summary>Connects an animation with the specified property of the object and starts the animation.</summary>
    /// <param name="propertyName">The property to associate the animation with.</param>
    /// <param name="animation">The animation to associate with the specified property.</param>
    [MethodImpl]
    public extern void StartAnimation(string propertyName, CompositionAnimation animation);

    /// <summary>Disconnects an animation from the specified property and stops the animation.</summary>
    /// <param name="propertyName">The name of the property to disconnect the animation from.</param>
    [MethodImpl]
    public extern void StopAnimation(string propertyName);

    /// <summary>A string to associate with the CompositionObject.</summary>
    /// <returns>A string to associate with the CompositionObject. Note that for Visual Studio's Live Visual Tree debugging tool, the name displayed for a particular visual will be pulled from its Comment property</returns>
    public extern string Comment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The collection of implicit animations attached to this object.</summary>
    /// <returns>The collection of implicit animations attached to this object.</returns>
    public extern ImplicitAnimationCollection ImplicitAnimations { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Starts an animation group.</summary>
    /// <param name="value">The animation group to start.</param>
    [MethodImpl]
    public extern void StartAnimationGroup(ICompositionAnimationBase value);

    /// <summary>Stops an animation group.</summary>
    /// <param name="value">The animation group to stop.</param>
    [MethodImpl]
    public extern void StopAnimationGroup(ICompositionAnimationBase value);

    /// <summary>Gets the DispatcherQueue for the CompostionObject.</summary>
    /// <returns>The DispatcherQueue for the CompostionObject.</returns>
    public extern DispatcherQueue DispatcherQueue { [MethodImpl] get; }

    /// <summary>Returns an AnimationController for the animation running on the specified property.</summary>
    /// <param name="propertyName">The property being animated.</param>
    /// <returns>An instance of AnimationController for the specified animation, or **null** if the animation is not found.</returns>
    [MethodImpl]
    public extern AnimationController TryGetAnimationController(
      string propertyName);

    [MethodImpl]
    public extern void Close();

    /// <summary>Defines a property that can be animated.</summary>
    /// <param name="propertyName">The property that can be animated.</param>
    /// <param name="propertyInfo">Information about the property to be animated.</param>
    [MethodImpl]
    public extern void PopulatePropertyInfo(string propertyName, AnimationPropertyInfo propertyInfo);

    /// <summary>Connects an animation with the specified property of the target object and starts the animation.</summary>
    /// <param name="target">The object that defines the property to be animated.</param>
    /// <param name="propertyName">The property to associate the animation with.</param>
    /// <param name="animation">The animation to associate with the specified property.</param>
    [MethodImpl]
    public static extern void StartAnimationWithIAnimationObject(
      IAnimationObject target,
      string propertyName,
      CompositionAnimation animation);

    /// <summary>Starts an animation group on the specified target.</summary>
    /// <param name="target">The object that defines the property to be animated.</param>
    /// <param name="animation">The animation to associate with the specified property.</param>
    [MethodImpl]
    public static extern void StartAnimationGroupWithIAnimationObject(
      IAnimationObject target,
      ICompositionAnimationBase animation);
  }
}
