﻿using System;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.UI.Experimental
{
    /// <summary>
    /// Interface for defining a proximity object provider used in <see cref="ProximityEffect" /> of <see cref="BoundsControl" />
    /// ProximityEffectObjectProviders are responsible for providing gameobjects that are scaled / visually altered in ProximityEffect.
    /// </summary>
    internal interface IProximityEffectObjectProvider
    {
        /// <summary>
        /// returns true if the provide has any visible objects
        /// </summary>
        /// <returns></returns>
        bool IsActive();

        /// <summary>
        /// Base Material is applied to any proximity scaled object whenever in medium or far/no proximity mode
        /// </summary>
        /// <returns></returns>
        Material GetBaseMaterial();

        /// <summary>
        /// Provides the highlighted material that gets applied to any proximity scaled object in close proximity mode
        /// </summary>
        /// <returns></returns>
        Material GetHighlightedMaterial();

        /// <summary>
        /// Returns the original object size of the provided proximity scaled objects
        /// </summary>
        /// <returns></returns>
        float GetObjectSize();

        /// <summary>
        /// This method allows iterating over the proximity scaled visuals. It should return the gameobject the scaling should be applied to.
        /// </summary>
        /// <param name="action"></param>
        void ForEachProximityObject(Action<Transform> action);
    }
}
