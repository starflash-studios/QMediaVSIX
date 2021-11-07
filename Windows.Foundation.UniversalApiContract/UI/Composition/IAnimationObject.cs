// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IAnimationObject
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Represents an object that has properties that can be referenced by an animation.</summary>
  [Guid(3876855306, 1208, 20421, 164, 220, 25, 83, 146, 229, 120, 7)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public interface IAnimationObject
  {
    /// <summary>Defines a property that can be animated.</summary>
    /// <param name="propertyName">The property that can be animated.</param>
    /// <param name="propertyInfo">Information about the property to be animated.</param>
    void PopulatePropertyInfo(string propertyName, AnimationPropertyInfo propertyInfo);
  }
}
