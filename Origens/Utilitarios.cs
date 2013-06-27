using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Origens
{
    public class Utilitarios
    {
        public System.Nullable<int> obterValorCombo(ComboBox c)
        {
            Int32 valorCombo;
            try
            {
                if (Int32.TryParse(c.SelectedValue.ToString(), out valorCombo))
                {
                    if (valorCombo < 0)
                        return null;
                    else
                        return valorCombo;
                }
                else
                {
                    valorCombo = Convert.ToInt32(((System.Data.DataRowView)c.SelectedValue).Row[0]);
                    if (valorCombo < 0)
                        return null;
                    else
                        return valorCombo;

                }
            }
            catch
            {
                return null;
            }
        }
        public System.Nullable<bool> obterValorBool(ComboBox c)
        {
            try
            {
                if (c.SelectedItem.ToString().Equals("Selecione"))
                {
                    return null;
                }
                else
                {

                    if (c.SelectedItem.ToString().Equals("Sim"))
                    {
                        return true;

                    }
                    else
                    {
                        if (c.SelectedItem.ToString().Equals("Não"))
                        {
                            return false;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }

            }
            catch
            {
                return null;
            }

        }
    }
}
