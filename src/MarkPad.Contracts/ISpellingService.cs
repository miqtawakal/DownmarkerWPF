﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace MarkPad.Contracts
{
	public interface ISpellingService
	{
		void ClearLanguages();
		void SetLanguage(SpellingLanguages language);

		bool Spell(string word);
	}
}