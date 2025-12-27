using System;
using System.Windows.Forms;
using Tyuiu.KhrapkoDD.Sprint7.Lib.Models;

namespace Tyuiu.KhrapkoDD.Sprint7.Desktop
{
    /// <summary>
    /// Форма для добавления или редактирования данных персонального компьютера (ПК).
    /// Может работать в двух режимах:
    /// - Создание нового ПК (параметр pc = null)
    /// - Редактирование существующего ПК (параметр pc != null)
    /// </summary>
    public partial class AddPcForm_KhrapkoDD : Form
    {
        /// <summary>
        /// Свойство для передачи созданного или изменённого объекта ПК в родительскую форму.
        /// Устанавливается только при успешном сохранении (кнопка "Сохранить").
        /// </summary>
        public PersonalComputer_KhrapkoDD? CreatedPc { get; private set; }

        /// <summary>
        /// Конструктор формы.
        /// Если передан объект pc — форма заполняется его данными (режим редактирования).
        /// </summary>
        /// <param name="pc">Объект ПК для редактирования. Если null — режим создания.</param>
        public AddPcForm_KhrapkoDD(PersonalComputer_KhrapkoDD? pc = null)
        {
            InitializeComponent();

            if (pc != null)
            {
                // Режим редактирования: заполняем поля формы данными из переданного объекта
                textBoxManufacturer_KhrapkoDD.Text = pc.Manufacturer ?? string.Empty;
                textBoxCpuType_KhrapkoDD.Text = pc.CpuType ?? string.Empty;
                numericUpDownFreq_KhrapkoDD.Value = (decimal)pc.ClockSpeedGHz; // ГГц
                numericUpDownRam_KhrapkoDD.Value = pc.RamGb;
                numericUpDownHdd_KhrapkoDD.Value = pc.HddGb;
                // Ограничиваем дату в допустимом диапазоне DateTimePicker
                dateTimePickerRel_KhrapkoDD.Value = pc.ReleaseDate > dateTimePickerRel_KhrapkoDD.MinDate
                    && pc.ReleaseDate < dateTimePickerRel_KhrapkoDD.MaxDate
                    ? pc.ReleaseDate
                    : DateTime.Today;
            }

            // Устанавливаем DialogResult по умолчанию на Cancel
            // Это важно, если пользователь закроет форму через крестик
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Сохранить".
        /// Проверяет обязательные поля, создаёт объект PersonalComputer_KhrapkoDD
        /// и закрывает форму с результатом OK.
        /// </summary>
        private void buttonSave_KhrapkoDD_Click(object sender, EventArgs e)
        {
            // Валидация обязательных полей
            string manufacturer = textBoxManufacturer_KhrapkoDD.Text.Trim();
            string cpuType = textBoxCpuType_KhrapkoDD.Text.Trim();

            if (string.IsNullOrEmpty(manufacturer))
            {
                MessageBox.Show("Поле 'Производитель' обязательно для заполнения.", "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxManufacturer_KhrapkoDD.Focus();
                return;
            }

            if (string.IsNullOrEmpty(cpuType))
            {
                MessageBox.Show("Поле 'Тип CPU' обязательно для заполнения.", "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxCpuType_KhrapkoDD.Focus();
                return;
            }

            // Создаём новый объект ПК на основе введённых данных
            CreatedPc = new PersonalComputer_KhrapkoDD
            {
                Manufacturer = manufacturer,
                CpuType = cpuType,
                ClockSpeedGHz = (double)numericUpDownFreq_KhrapkoDD.Value, // ГГц
                RamGb = (int)numericUpDownRam_KhrapkoDD.Value,
                HddGb = (int)numericUpDownHdd_KhrapkoDD.Value,
                ReleaseDate = dateTimePickerRel_KhrapkoDD.Value
            };

            // Устанавливаем результат диалога в OK и закрываем форму
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Отмена".
        /// Просто закрывает форму без сохранения (DialogResult остаётся Cancel).
        /// </summary>
        private void buttonCancel_KhrapkoDD_Click(object sender, EventArgs e) => Close();

        /// <summary>
        /// Обработчик закрытия формы (например, по крестику).
        /// Убеждаемся, что DialogResult установлен в Cancel, если данные не были сохранены.
        /// </summary>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Если пользователь уже нажал "Сохранить", то CreatedPc != null и DialogResult = OK — ничего не меняем
            if (DialogResult != DialogResult.OK)
            {
                DialogResult = DialogResult.Cancel;
            }
            base.OnFormClosing(e);
        }
    }
}