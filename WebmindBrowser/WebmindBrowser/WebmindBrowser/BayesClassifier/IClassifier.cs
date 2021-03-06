/* ====================================================================
 * Copyright (c) 2006 Erich Guenther (erich_guenther@hotmail.com)
 * All rights reserved.
 *                       
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions
 * are met:
 *
 * 1. Redistributions of source code must retain the above copyright
 *    notice, this list of conditions and the following disclaimer. 
 *
 * 2. Redistributions in binary form must reproduce the above copyright
 *    notice, this list of conditions and the following disclaimer in
 *    the documentation and/or other materials provided with the
 *    distribution.
 * 
 * 3. The name of the author(s) must not be used to endorse or promote 
 *    products derived from this software without prior written permission.
 *
 * THIS SOFTWARE IS PROVIDED BY THE AUTHOR ``AS IS'' AND ANY
 * EXPRESSED OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR
 * PURPOSE ARE DISCLAIMED.  IN NO EVENT SHALL THE AUTHOR OR
 * ITS CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
 * SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT
 * NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
 * LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)
 * HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT,
 * STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
 * ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED
 * OF THE POSSIBILITY OF SUCH DAMAGE. 
 */
using System;
using System.Collections.Generic;

namespace WebmindBrowser.BayesClassifier
{
    #region Interfaces
	/// <summary>
	/// Classifier methods.
	/// </summary>
	public interface IClassifier
	{
		/// <summary>
		/// Trains this Category from a word or phrase<\summary>
		void TeachPhrases(string cat, string[] phrases);

		/// <summary>
		/// Trains this Category from a word or phrase<\summary>
		void TeachCategory(string cat, System.IO.TextReader tr);

		/// <summary>
		/// Classifies a text<\summary>
		/// <returns>
		/// returns classification values for the text, the higher, the better is the match.</returns>
		Dictionary<string, double> Classify(System.IO.StreamReader tr);
	}
	/// <summary>
	/// Category methods.
	/// </summary>
	public interface ICategory
	{
		string Name { get; }
		/// <summary>
		/// Reset all trained data<\summary>
		void Reset();
		/// <summary>
		/// Gets a PhraseCount for Phrase or 0 if phrase not present<\summary>
		int GetPhraseCount(string phrase);

		/// <summary>
		/// Trains this Category from a file<\summary>
		void TeachCategory(System.IO.TextReader reader);
		/// <summary>
		/// Trains this Category from a word or phrase<\summary>
		void TeachPhrase(string rawPhrase);
		/// <summary>
		/// Trains this Category from a word or phrase array<\summary>
		void TeachPhrases(string[] words);
		/// <value>
		/// Gets total number of word occurences in this category</value>
		int TotalWords { get; }
	}
    #endregion
}
