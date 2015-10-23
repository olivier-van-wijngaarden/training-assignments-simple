﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Rectangle = eu.sig.training.ch05.boardpanel.v2.Rectangle;

namespace eu.sig.training.ch05.chartlib.v2 {
    // tag::BarChart[]
    public class BarChart {
        private CategoryItemRendererState state = CategoryItemRendererState.DEFAULT;
        private Rectangle graphArea = new Rectangle(new Point(0, 0), 100, 100);
        private CategoryPlot plot = CategoryPlot.DEFAULT;
        private CategoryAxis domainAxis = CategoryAxis.DEFAULT;
        private ValueAxis rangeAxis = ValueAxis.DEFAULT;
        private CategoryDataset dataset = CategoryDataset.DEFAULT;

        public BarChart draw(Graphics g) {
            // ..
            return this;
        }

        public ValueAxis getRangeAxis() {
            return rangeAxis;
        }

        public BarChart setRangeAxis(ValueAxis rangeAxis) {
            this.rangeAxis = rangeAxis;
            return this;
        }

        // More getters and setters.

        // end::BarChart[]

        public CategoryItemRendererState getState() {
            return state;
        }

        public BarChart setState(CategoryItemRendererState state) {
            this.state = state;
            return this;
        }

        public Rectangle getGraphArea() {
            return graphArea;
        }

        public BarChart setGraphArea(Rectangle graphArea) {
            this.graphArea = graphArea;
            return this;
        }

        public CategoryPlot getPlot() {
            return plot;
        }

        public BarChart setPlot(CategoryPlot plot) {
            this.plot = plot;
            return this;
        }

        public CategoryAxis getDomainAxis() {
            return domainAxis;
        }

        public BarChart setDomainAxis(CategoryAxis domainAxis) {
            this.domainAxis = domainAxis;
            return this;
        }

        public CategoryDataset getDataset() {
            return dataset;
        }

        public BarChart setDataset(CategoryDataset dataset) {
            this.dataset = dataset;
            return this;
        }

    }

    public class CategoryItemRendererState {
        public const CategoryItemRendererState DEFAULT = null;
    }

    public class CategoryPlot {
        public const CategoryPlot DEFAULT = null;
    }

    public class CategoryAxis {
        public const CategoryAxis DEFAULT = null;
    }

    public class ValueAxis {
        public const ValueAxis DEFAULT = null;
    }

    public class CategoryDataset {
        public const CategoryDataset DEFAULT = null;
    }

    public class BarChartTest : Form {
        ValueAxis myValueAxis = null;
        CategoryDataset myDataset = null;
        #pragma warning disable 219
        // tag::showMyBarChart[]
        private void showMyBarChart() {
            Graphics g = this.CreateGraphics();
            BarChart b = new BarChart()
                .setRangeAxis(myValueAxis)
                .setDataset(myDataset)
                .draw(g);
        }
        // end::showMyBarChart[]
        #pragma warning restore 219
    }
}
